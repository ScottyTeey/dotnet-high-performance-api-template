# 🚀 High-Performance ASP.NET Core API Template

Production-ready ASP.NET Core 8 API template optimized for **scalability, performance, and observability**.

Designed for startups and growing SaaS platforms that need a backend foundation capable of handling real-world load.

---

## 🎯 Purpose

Most .NET examples demonstrate CRUD functionality.

This template demonstrates:

* Performance-aware data access patterns
* Clean architecture principles
* Cloud-native readiness
* Observability & logging strategy
* Caching & rate limiting
* Background processing
* Production-grade configuration

This is not a demo project.
It is a **scalable backend foundation**.

---

## 🏗 Architecture Overview

This project follows a simplified Clean Architecture approach:

```
src/
 ├── Api
 ├── Application
 ├── Domain
 ├── Infrastructure
 ├── Persistence
tests/
```

### Core Principles

* Separation of concerns
* Explicit dependency boundaries
* Optimized data access paths
* Observability-first design
* Secure-by-default configuration

---

## 🛠 Tech Stack

* .NET 8 / ASP.NET Core
* SQL Server
* Entity Framework Core (optimized patterns)
* Dapper (for read-heavy scenarios)
* Redis (distributed caching)
* FluentValidation
* Serilog (structured logging)
* OpenTelemetry (tracing)
* Docker & Docker Compose
* Built-in Rate Limiting middleware
* Health Checks
* JWT Authentication

---

## ⚡ Performance Features

This template includes several production-grade performance strategies:

### 1️⃣ EF Core Optimization

* `AsNoTracking()` for read queries
* Split queries for large graphs
* Compiled queries for hot paths
* Indexed query examples
* Pagination patterns
* Cancellation tokens on all async calls

### 2️⃣ Hybrid Data Access

* EF Core for transactional writes
* Dapper for high-performance read endpoints

### 3️⃣ Distributed Caching

* Redis integration
* GET endpoint caching
* Sliding expiration
* Cache invalidation patterns

### 4️⃣ Rate Limiting

* Per-endpoint throttling
* IP-based control
* Prevents abuse under high load

### 5️⃣ Background Processing

* In-memory channel queue
* Retry logic
* Structured failure logging

### 6️⃣ Observability

* Structured JSON logging via Serilog
* Correlation ID middleware
* Request/response logging
* OpenTelemetry tracing ready

### 7️⃣ Health Checks

Endpoints:

```
/health
/health/live
/health/ready
```

Cloud-ready for Kubernetes / Azure App Services.

---

## 📦 Example Domain

The template includes a realistic sample domain:

**Orders API**

Endpoints:

* POST `/orders`
* GET `/orders/{id}`
* GET `/orders?status=...`
* POST `/payments`

Includes:

* Validation
* Caching
* Optimized queries
* Structured logging
* Proper response envelopes

---

## 🐳 Running with Docker

The project includes a `docker-compose.yml` with:

* API container
* SQL Server container
* Redis container

To start:

```bash
docker-compose up --build
```

The API will be available at:

```
http://localhost:5000
```

---

## 🔍 Observability

Logging is structured and production-ready.

Features:

* Correlation ID tracking
* Request logging
* Exception logging
* Distributed tracing support (OpenTelemetry)

This enables seamless integration with:

* Azure Monitor
* Application Insights
* Grafana
* ELK stack

---

## 🔐 Security

* JWT-based authentication
* Secure configuration handling
* Rate limiting
* Input validation via FluentValidation

---

## 📈 Scalability Considerations

This template is designed to scale horizontally:

* Stateless API
* Externalized cache
* Externalized database
* Background processing abstraction
* Cloud-native configuration

---

## 🚀 Azure Deployment

Ready for:

* Azure App Service
* Azure Container Apps
* AKS (Kubernetes)
* Azure SQL
* Azure Cache for Redis

Environment variables are fully configurable.

---

## 🧠 Why This Exists

Most backend failures happen due to:

* Poor data access strategy
* Lack of observability
* No caching strategy
* Tight coupling
* Ignoring performance until production

This template solves those problems from day one.

---

## 📌 Intended Audience

* SaaS startups
* CTOs needing a backend foundation
* Developers building scalable APIs
* Teams migrating legacy systems to modern .NET

---

## 📄 License

MIT

---


