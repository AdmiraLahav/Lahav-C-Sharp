# ***my C# projects***

## cheat sheet
### brackets:
() → somebody is doing something right now.

[] → grab me this one thing from the pile.

{} → here’s how I’m setting things up or grouping them.

## C# Value Types Cheat Sheet

Value types store **actual data**.  
Assigning them **copies the value** (independent variables).  
They live on the **stack** (fast memory).  

---

### Whole Numbers
- `byte`   (8-bit)   → 0 to 255  
- `sbyte`  (8-bit)   → –128 to 127  
- `short`  (16-bit)  → –32,768 to 32,767  
- `ushort` (16-bit)  → 0 to 65,535  
- `int`    (32-bit)  → –2,147,483,648 to 2,147,483,647  
- `uint`   (32-bit)  → 0 to 4,294,967,295  
- `long`   (64-bit)  → –9 quintillion to +9 quintillion  
- `ulong`  (64-bit)  → 0 to 18 quintillion  

---

### Floating-Point Numbers
- `float`   (32-bit)  → ~7 digits precision *(suffix: f)*  
- `double`  (64-bit)  → ~15–16 digits *(default)*  
- `decimal` (128-bit) → ~28–29 digits *(suffix: m, best for money)*  

---

### Other Basics
- `bool` → `true` / `false`  
- `char` → single Unicode character (16-bit), e.g. `'A'`  

---

### Special Value Types
- `enum`   → Named constants (backed by `int`)  
- `struct` → Custom value type (like a class, but stored on the stack)  

---

### Nullables
Any value type + `?` can hold `null`.  

```csharp
int? age = null;
