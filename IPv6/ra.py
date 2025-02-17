from scapy.all import * 
from scapy.layers.inet6 import * 
def generate_ra(prefix_block, prefixlen=64, router_lifetime=1800, reachable_time=600000, retrans_timer=1000):
        """     Gera um pacote Router Advertisement (RA) com o bloco de prefixo fornecido.     
        :param prefix_block: Bloco IPv6 (exemplo: '2001:db8::')     
        :param prefixlen: Comprimento do prefixo (tamanho do bloco, ex: 64)     
        :param router_lifetime: Tempo de vida do roteador em segundos     
        :param reachable_time: Tempo de rede detectável em milissegundos     
        :param retrans_timer: Tempo de retransmissão em milissegundos     
        :return: Pacote RA configurado     """     
        # Configuração de RA (Router Advertisement)     
        # ra = IPv6(dst="ff02::1") / ICMPv6ND_RA(routerlifetime=router_lifetime, reachabletime=reachable_time, retranstimer=retrans_timer) \         
        # / ICMPv6NDOptPrefixInfo(prefix=prefix_block, prefixlen=prefixlen, validlifetime=3600, preferredlifetime=1800) \        
        #  / ICMPv6NDOptSrcLLAddr(lladdr="00:11:22:33:44:55")  
        # # MAC fictício (altere conforme necessário)    
        #  return ra # Exemplo de uso: 
        # prefix = "2001:db8::"  
        # # Prefixo a ser anunciado 
        # ra_packet = generate_ra(prefix) 
        # 
        # Enviar o pacote na interface de rede (opcional) sendp(Ether() / ra_packet, iface="eth0")  