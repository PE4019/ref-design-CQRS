# About
This is a reference project for studying the CQRS design pattern.
It's examplified using an ASP.NET MVC web application. Some of the
interesting things implemented:

- Persistance layer with complete separation using Entity Framework
- Implemented the Repository Pattern
- Command interfaces
- Direct Injection of Controllers using Unity

The Domain layer of the application is a bit rough. Everything is
stuffed into the classlib "Domain.Core". A slightly better way of
implementing the Aggregates is needed.
