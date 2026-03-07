# Padronização E.P.I Control – C# Naming Conventions

## 🧩 Padrão de nomes para Componentes do Windows Forms

| Componente   | Prefixo | Exemplo        |
| ------------ | ------- | -------------- |
| Form         | `frm`   | `frmCliente`   |
| Button       | `btn`   | `btnSalvar`    |
| Label        | `lbl`   | `lblNome`      |
| TextBox      | `txt`   | `txtCpf`       |
| ComboBox     | `cbx`   | `cbxEstado`    |
| CheckBox     | `chb`   | `chbAtivo`     |
| RadioButton  | `rdb`   | `rdbMasculino` |
| DataGridView | `dgv`   | `dgvClientes`  |
| Panel        | `pnl`   | `pnlCadastro`  |
| GroupBox     | `grp`   | `grpEndereco`  |
| TabControl   | `tbc`   | `tbcCliente`   |
| MaskedTextBox| `mtb`   | `mtbRg`        |
| RichTextBox  | `rtb`   | `rtbComplemento`|
| DateTimePicker| `dtp`  | `dtpDataNascimento`|
| FlowLayoutPanel| `flp` | `flpContainer` |
| NumericUpDown| `nud`   | `nudNumero`|

## 🏗️ Padrão para Classes
Use a convenção "PascalCase" e nomes que representem claramente o papel da classe.
```
        ConnectionFactory
        ClienteDAO
        Cliente
```

## 📁 Separação de Camadas
Projeto sempre deve respeita a seguinte nomeclatura: "epicontrol.camada":
```
        📁 epicontrol.conexao
        📁 epicontrol.dao
        📁 epicontrol.model
        📁 epicontrol.views
```

## 🧠 Padrão para Variáveis
Use a convenção "camelCase" para definir nomes de variáveis.
```
        string nomeCliente;
        int idade;
        bool ativo;
        decimal valorTotal;
```

## 🔐 Constantes
```
        const int TAMANHO_MAX_NOME = 100;
        const string MSG_ERRO = "Erro ao salvar";
```

## ⚙️ Métodos (Funções)
Use a convenção "PascalCase", primeiro o verbo e logo após o nome:
```
        SalvarCliente()
        BuscarClientePorId()
        ValidarCampos()
        CalcularTotal()
```

# 🗃️ Banco de Dados (MySQL Workbench)
Tabelas devem começar com: "tb_nomeTabela":
```
        tb_clientes
        tb_produtos
        tb_usuarios
```

Campos devem começar com letras minusculas e caso seja uma palavra composta, deve ser separada por um "_":
```
        id_cliente
        nome
        cpf
        data_nascimento
        ativo
```
# Padronização dos Commits

## 📌 Estrutura do Commit
🧱 -> "Emoji" "Tipo":(nomeClasse): descrição breve", exemplo:
```
        ✨ feat(cliente): adicionar cadastro de cliente
        🐛 fix(clienteDAO): corrigir erro no update do cliente
        🎨 style(ui): padronizar nomes dos componentes

```

## ✅ Conventional Commits + Emoji

| Emoji | Tipo       | Quando usar         |
| ----- | ---------- | ------------------- |
| ✨     | `feat`     | Nova funcionalidade |
| 🐛    | `fix`      | Correção de bug     |
| ♻️    | `refactor` | Refatoração         |
| 🎨    | `style`    | Formatação / nomes  |
| 🔥    | `chore`    | Remover código      |
| 🧪    | `test`     | Testes              |
| 🔧    | `chore`    | Configuração        |
| 📝    | `docs`     | Documentação        |

## ⚠️ Regras importantes

- ✔ Emoji sempre no começo
- ✔ 1 emoji por commit
- ✔ Nunca usar emoji sem texto
- ✔ Nunca misturar vários tipos no mesmo commit
