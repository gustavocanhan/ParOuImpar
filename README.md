# 🧮 Par ou Ímpar

Projeto em **C# (console)** criado para praticar leitura e validação de entradas, uso do operador **módulo (%)** e controle de fluxo.  
O programa identifica se um número é **par** ou **ímpar** e exibe o total de cada um ao final da execução.

---

## 🎯 Objetivo

Ler números inteiros inseridos pelo usuário, informar se são pares ou ímpares e, ao final, mostrar um resumo com a contagem de todos os números digitados (exceto o **0**, que encerra o programa).

---

## ⚙️ Funcionamento

1. O usuário insere um número inteiro.  
2. O programa usa `int.TryParse()` para validar a entrada.  
3. Se o número for **0**, o programa encerra.  
4. Caso contrário:
   - Se `entrada % 2 == 0`, o número é **par**.  
   - Se não, o número é **ímpar**.  
5. Cada número digitado é contabilizado.  
6. Ao final, o programa mostra:
   - ✅ Total de números **pares**  
   - ✅ Total de números **ímpares**  
   - ✅ Mensagem de encerramento

---

## 🧠 Conceitos praticados

- Estrutura de repetição `while`
- Validação de entrada com `int.TryParse()`
- Operador módulo `%`
- Contadores e variáveis acumuladoras
- Estruturas condicionais `if` / `else`
- Interpolação de strings (`$"{variavel}"`)

---

## 💻 Exemplo de uso

```
Insira um número inteiro (0 para sair): 4
4 - PAR.

Insira um número inteiro (0 para sair): 7
7 - ÍMPAR.

Insira um número inteiro (0 para sair): -2
-2 - PAR.

Insira um número inteiro (0 para sair): 0

Total de números pares: 2
Total de números ímpares: 1

Programa encerrado.
```

---

## 📁 Estrutura do projeto

```
ParOuImpar/
│
├── Program.cs
└── ParOuImpar.csproj
```

---

## 💬 Possíveis melhorias futuras

- Mostrar a **porcentagem** de números pares e ímpares.  
- Armazenar todos os números digitados e exibi-los ao final.  
- Tratar **limites máximos e mínimos** de entrada.  
- Permitir repetir a execução sem reiniciar o programa.  
- Adicionar **cores no console** para destacar par/ímpar.

---

📘 **Autor:** Gustavo Canhan  
💡 *Projeto criado para estudo e prática em C#.*
