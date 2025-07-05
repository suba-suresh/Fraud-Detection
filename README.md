# Fraud-Detection

Suspicious Bet Order Detection System
(Beginner-friendly fraud filter for online betting platforms)


# Fraud Detection Console App

Detecting fraudulent or suspicious activity early helps protect players and the platform.

This C# console app simulates an order intake system and scans for:

- Orders starting with suspicious letters (like **B**, **X**, or **Z**)
- Abnormally high bet amounts (over a limit, e.g., $10,000)
- Duplicate Order IDs
- Orders from flagged user IDs

This system flags such orders and prints them for review. 

---

## 🔧 Technologies Used

- C# .NET Console Application 
- Basic arrays & string operations
- `foreach`, `if` conditions
- Simulated Data (order IDs, user IDs, amounts)

---

## 🛠️ Features  Build

### ✅ Order List with:
- Order ID
- User ID
- Bet Amount

### 🔍 Suspicion Rules:
- Starts with **B**, **X**, or **Z** → possibly bot-generated
- Bet Amount > 10,000 → unusually large
- Duplicate Order IDs → possible double submission
- Flagged User IDs → known suspicious accounts

---

## 📋 Sample Output of Suspicious Orders

```
📋 Print Suspicious Orders with reasons like:

🚨 Order B123 from User U777 flagged:
- Suspicious ID (starts with B)
- High Amount ($12,000)
```
