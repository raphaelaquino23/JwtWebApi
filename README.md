
# Backend API Registration Service with JWT Token Usage 🔐

This project is a fully functional backend API registration service, utilizing JSON Web Tokens (JWT) for authentication. It employs Hmac512 for hashing and salting passwords, ensuring secure user registration and authentication.

## Features ✨


- **User Registration:** Users can register by providing a username and password. 
- **User Authentication:** Users can authenticate using their registered credentials to receive a JWT token. 🔑
- **JWT Token Usage:** Authentication and authorization are managed using JWT tokens. 📜
- **Hmac512 Hashing and Salting:** Passwords are securely hashed and salted using the Hmac512 standard. 🔒
- **Secure Endpoints:** API endpoints are protected and require valid JWT tokens for access. 🛡️

## Technologies Used 🛠️

- **C#:** Programming language used to build the backend.
- **ASP.NET Core 6:** Framework for building web applications and APIs.
- **SQL Server:** Relational database management system for storing user data.
- **Entity Framework Core:** ORM (Object-Relational Mapping) framework for working with SQL Server.
- **JWT (JsonWebToken):** Library for generating and verifying JWT tokens.
- **Hmac512:** Hashing algorithm for password hashing and salting.
