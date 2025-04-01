# COFFEE_MACHINE
Here's the updated README reflecting your improved code:

# ☕ TJITTERS COFFEE MACHINE

This C# console app started as a simple project I built during my second year of college (when coffee became my primary food group). What began as a basic coffee ordering simulation has evolved into a more polished application that still carries that "student project" charm while incorporating some proper programming practices I've learned along the way.  

### Why This Exists  
- Born from equal parts caffeine cravings and academic requirements  
- My first real attempt at making something vaguely "production ready"  
- Proof that even student projects can grow up to have proper input validation  
- The coffee shop name? Let's just say I wasn't sleeping much that semester  

### What's Inside  
✔ **The Coffee Menu** - Because every student needs options (1-4, just like exam choices)  
✔ **Quantity Selector** - For those days when one coffee isn't gonna cut it  
✔ **Running Total** - So you know exactly how much dining hall money you're spending  
✔ **All The Validation** - Learned the hard way after classmates kept breaking my first version  

It's not fancy, but it works - kind of like the microwave ramen + energy drink diet that got me through that semester. The code shows its academic origins but now has some actual error handling and structure that would make my past professors nod approvingly.  

## Features

- **Menu System**: Clear display of coffee sizes and prices:
  - 1 - Small (R15.50)
  - 2 - Medium (R22.50)
  - 3 - Large (R35.50)
  - 4 - Extra-large (R43.50)

- **Order Processing**:
  - Multiple coffee orders in one session
  - Quantity selection with validation
  - Running total calculation

- **Enhanced User Experience**:
  - Clean, formatted output with clear sections
  - Comprehensive input validation
  - Detailed order summaries
  - Professional receipt display

- **Technical Improvements**:
  - Proper decimal handling for precise currency calculations
  - Dictionary-based menu system for easy maintenance
  - Modular methods for better organization
  - Proper loop structures (no goto statements)

## How to Use

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/tjitters-coffee-machine.git
   ```

2. **Run the application**:
   - Open in Visual Studio and build/run
   - Or compile with `dotnet build` and run with `dotnet run`

3. **Ordering Process**:
   ```
   1. Select coffee size (1-4)
   2. Enter quantity (positive number)
   3. View order summary
   4. Choose to continue or checkout
   5. Receive formatted final bill
   ```

## Code Structure

```csharp
CoffeeMachine/
│── Program.cs            # Main application with all logic
│   ├── CoffeeSizes       # Dictionary of available sizes/prices
│   ├── Main()            # Primary workflow
│   ├── DisplayWelcomeMessage()
│   ├── GetCoffeeSize()   # Size selection with validation
│   ├── GetQuantity()     # Quantity input with validation
│   ├── CalculateCost()
│   ├── DisplayOrderSummary()
│   ├── AskToContinue()   # Yes/No prompt with validation
│   └── DisplayFinalBill()
```

## Key Improvements from Previous Version

✔ **Eliminated goto statements** - Uses proper while loops  
✔ **Accurate decimal pricing** - No more integer approximation  
✔ **Enhanced input validation** - Handles all invalid cases gracefully  
✔ **Better code organization** - Modular methods with single responsibilities  
✔ **Professional output formatting** - Clear sections and currency formatting  
✔ **Dictionary-based menu** - Easier to maintain and update prices  

## Future Enhancements

- [ ] Add coffee customizations (milk, sugar, extras)
- [ ] Implement loyalty program/discounts
- [ ] Save order history to file
- [ ] Add admin mode for menu management
- [ ] Unit test coverage

## Requirements

- .NET 6.0 or later
- Visual Studio 2022 or VS Code (recommended)

## License

MIT License - Open source and free to modify/use

---

Would you like me to add any of the following to the README?
- Screenshot of the application in action
- Detailed installation instructions
- Contribution guidelines
- Badges (build status, version, etc.)
- Code quality metrics


     
