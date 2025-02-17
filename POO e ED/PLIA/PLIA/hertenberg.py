import numpy as np
import twilio

def dh_matrix(theta, d, a, alpha):
    """
    Calcula a matriz de transformação de Denavit-Hartenberg.
    
    Parâmetros:
        theta (float): Ângulo de rotação em torno do eixo z (em radianos).
        d (float): Deslocamento ao longo do eixo z.
        a (float): Comprimento da ligação ao longo do eixo x.
        alpha (float): Ângulo de torção ao longo do eixo x (em radianos).
        
    Retorna:
        np.array: Matriz de transformação homogênea 4x4.
    """
    # Matriz de transformação usando os parâmetros de Denavit-Hartenberg
    return np.array([
        [np.cos(theta), -np.sin(theta)*np.cos(alpha), np.sin(theta)*np.sin(alpha), a*np.cos(theta)],
        [np.sin(theta), np.cos(theta)*np.cos(alpha), -np.cos(theta)*np.sin(alpha), a*np.sin(theta)],
        [0, np.sin(alpha), np.cos(alpha), d],
        [0, 0, 0, 1]
    ])

def compute_transformations(dh_parameters):
    """
    Calcula as matrizes de transformação para uma lista de parâmetros DH.
    
    Parâmetros:
        dh_parameters (list of tuples): Lista de tuplas, onde cada tupla contém os parâmetros (theta, d, a, alpha) de cada junta.
        
    Retorna:
        list of np.array: Lista de matrizes de transformação homogêneas.
    """
    transformations = []
    for params in dh_parameters:
        theta, d, a, alpha = params
        # Calcular a matriz DH para os parâmetros dados
        dh_mat = dh_matrix(theta, d, a, alpha)
        transformations.append(dh_mat)
    return transformations

# Exemplo de uso:
# Defina os parâmetros DH para cada junta do seu robô (theta, d, a, alpha)
dh_params = [
    (np.pi/2, 0.5, 0.5, np.pi/4),    # Junta 1
    (np.pi/3, 0.2, 0.3, np.pi/6),    # Junta 2
    (np.pi/4, 0.3, 0.2, np.pi/3)     # Junta 3
]

# Calcular as matrizes de transformação para cada conjunto de parâmetros
transformations = compute_transformations(dh_params)

# Imprimir as matrizes de transformação
for i, t in enumerate(transformations):
    print(f"Matriz de transformação da Junta {i+1}:\n{t}\n")
