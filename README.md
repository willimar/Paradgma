# Paradgma

This is a sample code to using recursive search on the tree.

In the code we can found some simple validations.

Requirement from task: Portuguese language.

Considerando um array com uma sequencia de pares (pai, filho), crie o código necessário para resolver o array de forma que o resultado seja uma árvore que representa a estrutura hierárquica do array inicial.

Se não for possível construir a árvore por um dos motivos abaixo, deverá ser lançada a respectiva exceção:

|ID	| ERRO                  |
| - | --------------------- |
|E1	| Mais de 2 filhos      |
|E2	| Ciclo presente        |
|E3	| Raízes múltiplas      |
|E4	| Qualquer outro erro   |


The code was made using Console Application with .Net Core.

## Exemplo 1

**Array de entrada**: `[A,B] [A,C] [B,G] [C,H] [E,F] [B,D] [C,E]`

**Possíveis representações**:

![](tree.png)

**Resultado**: `A[[B[D][G]][C[E[F]][H]]]]`

## Exemplo 2

**Array de entrada**: `[B,D] [D,E] [A,B] [C,F] [E,G] [A,C]`

**Resultado**: `A[[B[D[E[G]]]][C[F]]]`

## Exemplo 3
**Array de entrada**: `[A,B] [A,C] [B,D] [D,C]`

**Resultado**: `Exceção E3`

## Resposta

O projeto que contem a resposta para a questã pode ser visto em: [Source code](./src/Pradigma)

### Implementação base

O arquivo de resposta pode ser lido em: [Solution](./src/Pradigma/PaisFilhos.cs)

### Exemplo de uso

Inicialização da aplicação console para uso da implementação: [Program](./src/Pradigma/Program.cs)
