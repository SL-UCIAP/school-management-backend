# School Management System (SMS)

## Overview
The **School Management System (SMS)** is a core subsystem of the **Unified Citizen Information Access Portal (UCIAP)**. It manages student academic records and provides verified educational data to UCIAP through secure APIs.

The system ensures that student information is accessed only by authorized institutions under strict authentication and consent controls.

---

## Key Features
- Student profile and academic record management
- Secure RESTful APIs for data retrieval
- Role-based access control
- Integration with UCIAP for education data verification
- Audit-friendly data access

---

## Technology Stack
### Backend
- .NET 8 (ASP.NET Core Web API)

### Frontend
- Angular

### Database
- PostgreSQL / SQL Server

### Security
- OAuth 2.0 / OpenID Connect
- JWT-based authentication
- Keycloak (via UCIAP)

---

## System Integration
- Operates as an **education data provider** within the UCIAP ecosystem
- Communicates with UCIAP through secure REST APIs
- Does not expose student data directly to third parties
- All requests are validated using Keycloak-issued JWT tokens

---

## Developer
- **Garuka Gimhan**

---

## Purpose
This system was developed for academic purposes to demonstrate:
- Secure student data management
- API-driven system integration
- Modern authentication and authorization practices

---

## License
This project is intended for educational use only.


