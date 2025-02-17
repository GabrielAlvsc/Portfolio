from pacotes import *


# Inicia com um broadcast de ROUTER ADVERTISMENT
packet = ipv6_router_solicitation()
packet.show()
sendp(packet)


