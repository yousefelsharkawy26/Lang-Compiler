# Lang Compiler

## 🔹 Brief: Custom Language Grammar + Windows Forms Parser Tool

### 1️️⃣ Grammar Overview

This grammar defines a custom programming language with support for:

- **Variable Declarations**: including primitives (`fact`, `text`, `letter`, `auto`, `num`) and complex types (`list<...>`, `array[...]`, and custom classes)
- **Expressions**: arithmetic, logical, and ternary operations
- **Control Structures**: `if-else`, `switch-case`, and loops (`while`, `do-while`, `for`)
- **Functions**: procedure declarations and calls
- **Classes/Structs**: custom object types using `build` and `struct`
- **Object Instantiation**: with syntax like `object Person p = new();`

### 2️️⃣ Windows Forms UI

This is a C# Windows Forms application that provides a graphical interface to:

- ✍️ Write code in a `RichTextBox`
- ▶️ Trigger parsing with a `Button`
- 📝 Display parsing results or errors in a `ListBox`
- 🔁 Optionally render the parse tree in a `TreeView`

#### Example UI Components:

| Control Type | Name        | Description                     |
| ------------ | ----------- | ------------------------------- |
| RichTextBox  | `txtCode`   | Input area for source code      |
| Button       | `btnParse`  | Executes the parsing process    |
| ListBox      | `lstErrors` | Lists syntax/parse errors       |
| TreeView     | `treeParse` | (Optional) shows the parse tree |

### 3️️⃣ Parsing with Calitha Engine (GOLD Parser)

This tool uses the **Calitha Engine**, a .NET library compatible with GOLD Parser grammar tables (`.egt` files).

#### Integration Steps:

1. Design the grammar using **GOLD Parser Builder**
2. Export the grammar table as `.egt`
3. Load and parse input using Calitha in C#:

```csharp
Parser parser = new Parser(new CGTReader("MyGrammar.egt"));
```

4. Sample usage in the button click event:

```csharp
private void btnParse_Click(object sender, EventArgs e)
{
    Parser parser = new Parser(new CGTReader("MyGrammar.egt"));
    parser.Open();
    parser.Parse(txtCode.Text);

    lstErrors.Items.Clear();
    if (parser.Errors.Count > 0)
    {
        foreach (var error in parser.Errors)
            lstErrors.Items.Add(error.ToString());
    }
    else
    {
        MessageBox.Show("Parsing successful!");
        // Optionally, display parse tree
    }
}
```

### ✅ Output and Use Case

- Validates and parses source code in the custom language
- Visual interface makes it suitable for education or prototyping
- Easily extensible into a custom IDE for your DSL

---

![Screenshot](Resources/screenshot.png)
