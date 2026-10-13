# 🚦 API Gateway Test Automation Suite

[![CI Pipeline](https://github.com/MSBHOSLE/api-gateway-test-automation-suite/actions/workflows/ci.yml/badge.svg)](https://github.com/MSBHOSLE/api-gateway-test-automation-suite/actions)
[![Python](https://img.shields.io/badge/Python-3.11%2B-blue?logo=python&logoColor=white)](https://python.org)
[![C# .NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![NUnit](https://img.shields.io/badge/NUnit-4.0-25A162?logo=nunit&logoColor=white)](https://nunit.org/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

An end-to-end API gateway test automation and contract verification framework implemented in **Python (Pytest / Unittest)** and **C# (NUnit)**. Validates authentication handshakes, RBAC privilege boundaries, sliding window rate limits, and proxy routing contracts.

---

## ⚡ Test Coverage Matrix

- **Authentication Contracts**: Validates signed JWTs, expired signatures, missing schemes, and RBAC authorization matrices.
- **Rate Limit Quota Validation**: Validates sliding window headers (`X-RateLimit-*`) and burst 429 response handling.
- **Cross-Platform Dual-Language Execution**: Native test runners in Python and C# .NET 8.

---

## 🚀 Running the Tests

### Python
```bash
python -m unittest discover tests/python
```

### C# .NET
```bash
dotnet test tests/csharp/ApiGateway.Tests.csproj
```

---

## 👤 Author

**Mahesh Sanjayrao Bhosle**
- **GitHub:** [@MSBHOSLE](https://github.com/MSBHOSLE)
- **LinkedIn:** [Mahesh Bhosle](https://linkedin.com/in/mahesh-bhosle-916991198)
- **Email:** msbhosle.2@gmail.com
- **Education:** M.Sc. Data & Computer Science, Heidelberg University

---

## 📄 License

MIT License - see [LICENSE](LICENSE).
