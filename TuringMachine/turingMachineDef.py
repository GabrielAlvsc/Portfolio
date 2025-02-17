import json
import os

def file_Write(path,s): #Escreve linha s no arquivo no caminho path
    with open(path, 'a') as f:
        f.write(f'{s}\n')

def check_Parameters(q0, qa, qr, sigma, gamma,  q): 
    """Checar se algum pré-requisito não foi obedecido 0 se algum pre-requisito nao foi cumprido, 1 se todos foram cumpridos"""
    if not (q0 in q): #Estado inicial está em Q
        return 0
    if (str(type(qa)) == "<class 'str'>"):  
        if not (qa in q): #Aceitação em Q se tiver só um elemento
            return 0
    else: 
        for i in qa: #Para mais de um estado, confere se todos estão em Q
            if not (i in q):
                return 0
    if qr != []: #no caso da MT não ter um estado de rejeição
        if not (qr in q): #Rejeição em Q
            return 0
    for i in sigma: 
        if not (i in gamma): #Checar se cada simbolo de sigma esta em gamma
            return 0
    if not ('_' in gamma): #Checar se o Branco esta em gamma
        return 0
    return 1
    
def tm_Pass(t,dict,halt,head, tState, tRead, txt):
    if (tState in halt[0]) or ((tState) in halt[1]) :
        return tState
    else:

        in_ftrans = f'{tState},{tRead}'
        if not(in_ftrans in dict["ftrans"]): return tm_Pass(t, dict, halt, head, halt[1], tRead, txt) #halt[1] = rejeita, e para na proxima recursão
        else:
            text = (f't({in_ftrans}) -> ({dict["ftrans"][in_ftrans]["newstate"]},{dict["ftrans"][in_ftrans]["write"]},{dict["ftrans"][in_ftrans]["move"]})')
            file_Write(txt, text)

            t[head]=dict["ftrans"][in_ftrans]["write"]

            head += dict["ftrans"][in_ftrans]["move"]
            if (head < 0) : head = 0 #a MT é finita à esquerda

            tState = dict["ftrans"][in_ftrans]["newstate"]
            tRead = str(t[head])

            fita=(f'fita: {t}, cabeca: {head}\n') #teste
            file_Write(txt, fita)

            return tm_Pass(t, dict, halt, head, tState, tRead, txt)

def tm_Execute(w,dict, txt):
    """Execução da maquina de Turing, w = cadeia de entrada, dict = sétupla de entrada"""
    track = list(f'{w}___')
    file_Write(txt, f'fita inicial:\n {track}\n')
    headpos = 0
    halt = [str(dict["accept"]), str(dict["reject"])] #parada
    trackState = dict["init"]
    trackRead = str(track[headpos])
    
    trackOut = tm_Pass(track, dict, halt, headpos, trackState, trackRead, txt)
    if str(trackOut) in halt[0]: file_Write(txt, f'A MT aceita a cadeia {w} Estado: {str(trackOut)}\n')
    else: file_Write(txt, f'A MT rejeita a cadeia {w}: \n')
    file_Write(txt, f'fita final:\n {track}\n')

def main():

    filename=str(input("Digite o nome do arquivo da sétupla de entrada: ")) #Entrada do nome do arquivo

    with open(f'TMs/{filename}.json') as jf: #Abre o arquivo json com esse nome na pasta TMs
        mt7 = json.load(jf) #copia todo o conteudo do json para um dicionario

    
    txtpath=f'outputs/{filename}.txt' #Caminho de saida
    if os.path.exists(txtpath):
        os.remove(txtpath) #Apaga uma saida existente com o mesmo nome
    with open(txtpath, 'a') as f: 
        f.write("Sétupla de de entrada (Q,Ein,Efita,ft(),q0,qaceita,qrejeita): \n")
        f.write(json.dumps(mt7, indent=4)) #Escreve a sétupla de entrada no arquivo de saida
        f.write("\n")

    if check_Parameters(mt7["init"],mt7["accept"],mt7["reject"],mt7["alfa_in"],mt7["alfa_fita"],mt7["estados"]) == 1: 
        #checamos todos os parametros de mt7
        print("MT válida: executando...")
        word = str(input())
        v = True
        for i in word:
            if not (i in mt7["alfa_in"]): #Confere se a cadeia
                v = False
                break
        if v == True:
            file_Write(txtpath, f'Cadeia de entrada: {word}\n')
            tm_Execute(word,mt7,txtpath)
        else:
            file_Write(txtpath, f'A MT rejeita a cadeia {word}, pois há símbolos que não pertencem ao alfabeto\n')            
    else:
        print("MT inválida, algum pré-requisito não foi obedecido, ofereça outra entrada")

main()