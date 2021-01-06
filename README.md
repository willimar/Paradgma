# Paradgma

This is a sample code to using recursive search on the tree.

In the code we can found some simple validations.

Requirement from task: Portuguese language.

## Task 1

Considerando um array com uma sequencia de pares (pai, filho), crie o código necessário para resolver o array de forma que o resultado seja uma árvore que representa a estrutura hierárquica do array inicial.

Se não for possível construir a árvore por um dos motivos abaixo, deverá ser lançada a respectiva exceção:

|ID	| ERRO                  |
| - | --------------------- |
|E1	| Mais de 2 filhos      |
|E2	| Ciclo presente        |
|E3	| Raízes múltiplas      |
|E4	| Qualquer outro erro   |


The code was made using Console Application with .Net Core.

### Exemplo 1

**Array de entrada**: `[A,B] [A,C] [B,G] [C,H] [E,F] [B,D] [C,E]`

**Possíveis representações**:

![](tree.png)

**Resultado**: `A[[B[D][G]][C[E[F]][H]]]]`

### Exemplo 2

**Array de entrada**: `[B,D] [D,E] [A,B] [C,F] [E,G] [A,C]`

**Resultado**: `A[[B[D[E[G]]]][C[F]]]`

### Exemplo 3
**Array de entrada**: `[A,B] [A,C] [B,D] [D,C]`

**Resultado**: `Exceção E3`

### Resposta

O projeto que contem a resposta para a questã pode ser visto em: [Source code](./src/Pradigma)

### Implementação base

O arquivo de resposta pode ser lido em: [Solution](./src/Pradigma/PaisFilhos.cs)

### Exemplo de uso

Inicialização da aplicação console para uso da implementação: [Program](./src/Pradigma/Program.cs)

## Task 2

Escreva uma consulta usando linguagem SQL para encontrar os colaboradores que tem o salário mais alto em cada um dos departamentos.

A tabela Pessoa possui a relação de todos os colaboradores de uma empresa. Cada pessoa tem um Id, um salário, e também uma coluna para o ID do departamento.

| Id | Nome  | Salario | DeptId |
| -- | ----- | ------- | ------ |
| 1  | Joe   | 70000   | 1      |
| 2  | Henry | 80000   | 2      |
| 3  | Sam   | 60000   | 2      |
| 4  | Max   | 90000   | 1      |

A tabela Departamento contém a lista de departamentos da empresa.

| Id | Nome   |
| -- | ------ |
| 1  | TI     |
| 2  | Vendas |

Resultado esperado:

| Departamento | Pessoa | Salario |
| ------------ | ------ | ------- |
| xxxx         | xxxxx  | ?       |
| yyyy         | yyyy   | ?       |


### Resposta

  ```sql
  select
    Dept.Nome Departamento,
    colab.Nome Pessoa,
    colab.Salario Salario
  from 
    tbColaboradores colab
    inner join tbDepartamento dept on (dept.Id = colab.DeptId)
  order by
    dept.Id,
    colab.Salario desc
```
