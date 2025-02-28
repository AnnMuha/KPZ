# Warehouse Management System

## Programming Principles Used

### 1. DRY (Don't Repeat Yourself)
- В коді використовуються методи `IncreaseStock` та `DecreaseStock` для зміни кількості товару, що дозволяє уникнути дублювання коду.  
  - [Product.cs, рядок 36 та 42](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Product.cs#L36)

### 2. KISS (Keep It Simple, Stupid)
- Код чітко структурований: класи `Product`, `Warehouse`, `Reporting` мають зрозумілі та прості методи для обробки складу.
  - [Product.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Product.cs)
  - [Warehouse.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Warehouse.cs)
  - [Reporting.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Reporting.cs)
    
### 3. SOLID Principles

#### S - Single Responsibility Principle (SRP)
- `Product` зберігає дані про товар.  
- `Warehouse` займається зберіганням і маніпуляціями з товарами.  
- `Reporting` відповідає за звітність.  
  - [Product.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Product.cs), [Warehouse.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Warehouse.cs), [Reporting.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Reporting.cs)

#### O - Open/Closed Principle (OCP)
- Клас `Product` дозволяє додавати нові методи для роботи з ціною (наприклад, знижки), не змінюючи його структуру.
  - [Product.cs, рядок 28](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Product.cs#L28)

#### L - Liskov Substitution Principle (LSP)
- Клас `Money` можна розширити підкласи, наприклад, `USD`, `EUR`, `UAH`, і вони коректно працюватимуть у місцях, де використовується `Money`.
  - [Money.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Money.cs)

#### I - Interface Segregation Principle (ISP)
- `IProductManager` та `IReporting` поділяють обов’язки: один працює зі складом, інший – із звітністю.
  - [IProductManager.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/IProductManager.cs), [IReporting.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/IReporting.cs)

#### D - Dependency Inversion Principle (DIP)
- `Reporting` працює з `IProductManager`, а не з конкретним класом `Warehouse`, що дозволяє змінювати реалізацію складу без зміни коду `Reporting`.
  - [Reporting.cs, рядок 9](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Reporting.cs#L9)

### 4. YAGNI (You Ain’t Gonna Need It)
- Код не містить зайвих методів, які не використовуються у функціональності програми.

### 5. Composition Over Inheritance
- Клас `Product` містить об'єкт `Money`, а не успадковується від нього, що робить код гнучкішим.
  - [Product.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Product.cs)

### 6. Program to Interfaces, Not Implementations
- Використання `IProductManager` та `IReporting` дозволяє легко змінювати реалізацію.
  - [IProductManager.cs](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/IProductManager.cs)

### 7. Fail Fast
- Якщо при спробі відвантаження недостатньо товару, одразу виводиться повідомлення про помилку.
  - [RegisterProductShipment.cs, рядок 30](https://github.com/AnnMuha/KPZ/blob/lab_1/Lab_1/Lab_1/Reporting.cs#L30)

---

## How to Run the Project
1. Open the solution in **Visual Studio** or **VS Code**.
2. Build the project.
3. Run `Program.cs`.

---

## Author
- **Mukha Ann, VT-23-1**
