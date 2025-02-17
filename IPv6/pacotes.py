from scapy.all import *
from scapy.layers.inet6 import *
from scapy.layers.dns import *

def ipv6_router_advertisement(
    mac_src = False,
    # mac_src = "E4:A8:DF:F3:8A:6F",
    # mac_dst = "FF:FF:FF:FF:FF:FF",  # Endereço MAC de destino
    src_ip = False,
    # src_ip="fe80::1",  # Endereço IP de origem
    ll = False,
    dst_ip="ff02::1",  # Endereço IP de destino
    cur_hop_limit=64,  # Limite de saltos
    router_lifetime=1800,  # Tempo de vida do roteador (em segundos)
    reachable_time=0,  # Tempo de acessibilidade (em milissegundos)
    retrans_timer=0,  # Temporizador de retransmissão (em milissegundos)
    prefix_info="2804:1e68:c211:2cfb::",  # Informação do prefixo IPv6
    dns_servers=["2001:1291::197:34", "2001:1291::197:37"],  # Servidores DNS recursivos
    dst_mac = "33:33:00:00:00:01", #multicast para hosts
    mtu_ = "1500"
):
    # Criando o pacote Ethernet
    if mac_src: eth = Ether(src=mac_src, dst=dst_mac, type=0x86DD)
    else: eth = Ether(dst=dst_mac, type=0x86DD)  # Type 0x86DD indica IPv6
    
    # Criando o pacote IPv6
    if src_ip: ipv6=IPv6(src=src_ip, dst=dst_ip) 
    else: ipv6=IPv6(dst=dst_ip)
    
    # Criando o pacote ICMPv6 Router Advertisement
    icmpv6_ra = ICMPv6ND_RA(
        chlim=cur_hop_limit,  # Limite de saltos
        routerlifetime=router_lifetime,  # Tempo de vida do roteador
        reachabletime=reachable_time,  # Tempo de acessibilidade
        retranstimer=retrans_timer  # Temporizador de retransmissão
    )
    
    # Adicionando opções ICMPv6
    if ll: options_0 =  ICMPv6NDOptSrcLLAddr(lladdr=ll)  # Opção: Endereço link-layer de origem
    else: options_0 =  ICMPv6NDOptSrcLLAddr(lladdr=eth.src)  # Opção: Endereço link-layer de origem
    options_1 = ICMPv6NDOptPrefixInfo(prefix=prefix_info, prefixlen=64)  # Opção: Informação do prefixo
    options_2 = ICMPv6NDOptMTU(mtu=mtu_)
    options_3 = ICMPv6NDOptRDNSS(dns=dns_servers)  # Opção: Servidores DNS recursivos
    
    # Montando o pacote completo
    packet = eth / ipv6 / icmpv6_ra / options_0 / options_1 / options_2 / options_3
    # for op in options:
    #     packet = packet/op
    
    return packet

def ipv6_router_solicitation(
    # mac_src = "E4:A8:DF:F3:8A:6F",
    # mac_dst = "FF:FF:FF:FF:FF:FF",
    src_ip = False,
    mac_src = False,
    ll = False,
    dst_ip = "ff02::2", #IP de broadcast de router
    ipv6_multicast = "33:33:00:00:00:02"
    
):
        
    # Criando o pacote Ethernet
    if mac_src: eth = Ether(src=mac_src, dst=ipv6_multicast, type=0x86DD)  
    else: eth = Ether(dst=ipv6_multicast, type=0x86DD) #sem mac_src, pega o mac do pc

    # Criando o pacote IPv6
    if src_ip: ipv6=IPv6(src=src_ip, dst=dst_ip) 
    else: ipv6=IPv6(dst=dst_ip) #pega o ip6 do pc se desmarcar src, talvez não seja necessário, pois a intenção é obter o IP do router

    #Criando o pacot RS, simples
    icmpv6_rs = ICMPv6ND_RS()

    #Opcao de SrcLLADDR
    if ll: options_0 = ICMPv6NDOptSrcLLAddr(lladdr=ll) #Este pacote não é estritamente necessário
    else: options_0 = ICMPv6NDOptSrcLLAddr(lladdr=eth.src) #Este pacote não é estritamente necessário
    
    packet = eth / ipv6 / icmpv6_rs / options_0 #pacote completo
    return packet

def ipv6_neighbor_solicitation(
    mac_src=False,
    ll=False,
    tgt_ip = "2001:1290:0:29:9a0:474b:ddc5:ef27",
    src_ip = "::",
    nonce=False #Nonce nao foi implementado no scapy, nao enviar
    # dst_ip = "ff02::1:ff62:826c"
    # ip6cast = "33:33:ff:62:82:6c"
): 
    #Manipulando o ip target para obter o ip e mac multicast
    tg = tgt_ip[-7:]
    dst_ip = f"ff02::1:ff{tg}" #define o endereço ip para multicast
    ip6cast = f"33:33:ff:{tg[:5]}:{tg[5:]}" #define o mac multicast

    #Criando o pacote Ethernet
    if mac_src: eth = Ether(src=mac_src,dst=ip6cast, type=0x86DD)
    else: eth = Ether(dst=ip6cast, type=0x86DD)

    #Criando pacote Ipv6
    ipv6 = IPv6(src=src_ip, dst=dst_ip)

    #Criando o pacote icmpv6
    icmpv6_ns = ICMPv6ND_NS(tgt=tgt_ip)

    #pacote opts
    if nonce: options_0 = ICMPv6NDOptUnknown(type=14, len=1, data="b''") #NS Nonce, host solicitando mac de algum outro host
    #nao sei como essa string é gerada
    #nonce nao foi implementado no scapy
    elif ll: options_0 = ICMPv6NDOptSrcLLAddr(lladdr=ll)
    else: options_0 = ICMPv6NDOptSrcLLAddr(lladdr=eth.src) #quando veio esse pacote, recebeu NA, porém os demais foram enviados com Nonce

    packet = eth / ipv6 / icmpv6_ns / options_0
    return packet # options_4 = ICMPv6NDOptUnknown(type=14, len=1, data='d00e5e3672c4') #NS

def ipv6_neighbor_advertisement(
    mac_src = False,
    src_ip = False,
    ll = False,
    tgt_ = False,
    r=0,
    s=1,
    o=1,
    dst_mac = "dc:77:4c:f4:36:10"
): 
    
    #Manipulando o dst_mac para obeter os ip target 
    b1 = bin(int(dst_mac[1],16))[2:].zfill(4) #1 passo pra alterar 7 bit
    b2 = 1-int(b1[2]) #2 passo
    b1 = f"{b1[:2]}{b2}{b1[-1]}"
    b1 = hex(int(b1,2))[2:] #3 passo
    dm = f"{dst_mac[0]}{b1}{dst_mac[2:]}" #d redefine para dst_ip
    d1 = dm[:8].replace(":","",1) #retira o primeiro :
    d2 = dm[9:][::-1].replace(":","",1)[::-1] #retira o ultimo :
    dst_ip = f"fe80::{d1}ff:fe{d2}"
    #FORMATACAO PARA DEFINIR O FORMATO CORRETO DE IP DE DESTINO NO IPV6

    #Criando o pacote Ethernet
    if mac_src: eth = Ether(src=mac_src, dst=dst_mac, type=0x86DD)
    else: eth = Ether(dst=dst_mac, type=0x86DD)

    #Criando o pacote IPv6
    if src_ip: ipv6 = IPv6(src=src_ip, dst = dst_ip)
    else: ipv6 = IPv6(dst = dst_ip)

    #Criando o pacot Icmpv6
    if tgt_: icmpv6 = ICMPv6ND_NA(tgt=tgt_, R=r, S=s, O=o) 
    else: icmpv6 = ICMPv6ND_NA(tgt=ipv6.src, R=r, S=s, O=o) 

    #Criando o pacote lladdr
    if ll: options_0 = ICMPv6NDOptDstLLAddr(lladdr=ll)
    else: options_0 = ICMPv6NDOptDstLLAddr(lladdr=eth.src) #target é quem envia o NA/recebe o NS

    packet = eth / ipv6 / icmpv6 / options_0
    return packet 

def mdns(
    mac_src = False,
    src_ip = False,
    ll = False,
    dst_mac = ""
): 
    
    if mac_src: eth = Ether(src=mac_src, dst=dst_mac, type=0x86DD)
    else: eth = Ether(dst=dst_mac, type=0x86DD)

    dnsqr = DNSQR()
    dns = DNS()



    packet = eth
    return packet 

