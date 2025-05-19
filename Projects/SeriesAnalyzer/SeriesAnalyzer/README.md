<!-- Project Badges -->
<p align="center">
  <img src="https://img.shields.io/badge/.NET-6.0-blue?logo=dotnet" alt=".NET 6.0" />
  <img src="https://img.shields.io/badge/Status-Completed-green" alt="Status: Completed" />
</p>

# 🎉 Series Analyzer

*“Crunch numbers, discover patterns!”*

A delightful C# console app that turns your list of positive numbers into insights - fast and fun.


---
## ✍️ Author

**Shemaryahu Zalmanov**  
Passionate C# learner.  
📬 [Shemaryahu Zalmanov](mailto:shemaryahuz@gmaile.com) | [GitHub](https://github.com/shemaryahuz)

---
## 🚀 Features

- **🥳 Easy Input**  
  - Command-line args or interactive prompt  
  - Validates at least **3 positive numbers**  
- **📊 Menu-Driven UI**  
  1. Replace series  
  2. Display original order  
  3. Display reversed order  
  4. Display sorted (low → high)  
  5. Show **Max**  
  6. Show **Min**  
  7. Show **Average**  
  8. Show **Count**  
  9. Show **Sum**  
  10. **Exit**  
- **🔄 Live Replacement**  
  Swap in a new series whenever you choose.

---

## 🎬 Quick Demo

<p align="center">
  <img src="https://media.giphy.com/media/l0MYC0LajbaPoEADu/giphy.gif" alt="Demo GIF" width="500"/>
</p>

---

## 🛠️ Getting Started

### Prerequisites

- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)

### Build & Run
```bash
# Clone repo
git clone https://github.com/shemaryahuz/series-analyzer.git
cd series-analyzer

# Build
dotnet build

# Run interactively
dotnet run

# Or with initial numbers
dotnet run -- 1.2 3 4.5 6
