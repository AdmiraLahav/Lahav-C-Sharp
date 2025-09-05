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



## C# Reference Types Cheat Sheet

Reference types store a **reference (address)** to the data, not the data itself.  
Assigning them **copies the reference**, so two variables can point to the **same object**.  
They live on the **heap** (shared memory).  

---

### Core Reference Types
- `string` → sequence of characters (immutable, cannot be changed once created)  
- `object` → base type of *all* other types in C#  
- `class`  → blueprint for objects (can hold data + methods)  
- `interface` → contract for classes to implement  
- `delegate` → reference to a method (used for callbacks/events)  

---

### Collections
- `array` (e.g. `int[]`) → fixed-size sequence of elements  
- `List<T>` → resizable list (from `System.Collections.Generic`)  
- `Dictionary<TKey, TValue>` → key/value pairs  
- Many more: `Queue<T>`, `Stack<T>`, `HashSet<T>`, etc.  

---

### Behavior
- **Shared state**: if two variables reference the same object, changes through one are visible through the other.  
- **Null**: reference types can be `null` (pointing to nothing).  

Example:
```csharp
Student s1 = new Student();
s1.Name = "Lahav";

Student s2 = s1;   // both point to the same object
s2.Name = "Dana";

Console.WriteLine(s1.Name);  // prints "Dana"

int? age = null;
