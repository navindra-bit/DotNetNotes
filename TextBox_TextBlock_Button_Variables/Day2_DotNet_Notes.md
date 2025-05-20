
# 📝 .NET WPF Notes – Day 2

## 📌 GitHub Basics
- We can store our project in GitHub (source management).
- Share your code with others.
- Use **labels** to organize.
- `xmlns` → XML namespace.
- `x:` → alias for XAML names.

---

## 📦 WPF Controls

### 1. **TextBlock**
- Used to place simple text.

### 2. **TextBox**
- Used for **free text input**.
- `Text="value"` → sets a string value.
- `IsReadOnly="True"` → makes TextBox read-only.
- User **cannot input** anything if it's read-only.

### 3. **Button**
- Used to **click and get result**.
- Event binding: `Click` → used to create an event.

---

## 🔢 Variable Examples

```csharp
int number = 10; // For numbers
string str = "Hello"; // For words
char ch = 'e'; // For a single character
```

## 🔁 Initialization and Declaration

```csharp
int number;
number = 30; // Initialized later
```

---

## 🧮 String and Integer Conversion

### Example:
```csharp
int num = 20;
num = 30; // num will become 30
```

### String overwrite:
```csharp
string str = "Hello";
str = "World"; // str becomes "World"
```

### Conversion:
- `Convert.ToInt16()` → convert string to int
- `Convert.ToString()` → convert int to string

### Addition Example:
```csharp
string num1 = "10";
string num2 = "20";
string result = num1 + num2;
// Output: "1020"
```

To add their **numeric values**, convert to int first.
