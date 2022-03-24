we are aplling fluent Api for creating of model. we should not apply 
DataAnottation whic can break down the SRP.

usermap and userprofilemap is implimenting fluent api for user and userprofile.

using Microsoft.EntityFrameworkCore.Metadata.Builders;
(for fluent api)

5th may

HOW YOU WILL IMPLMENT FLUENT API IN YOUR PROJECT

we apllied fluent api in usermap.cs and userprofilemap.cs with the help of (EntityTypeBuilder
now we need to associate to bind the user and the usermap.
now we need to associate to bind the userprofile and the userprofilemap.
mapping is to be done by virtual function of Dbcontext class. so we nee dto make a class
inheriting from the Dbcontext class when we need to override the virtual fuction of Dbcontext class

Diffrence between EntityTypeBuilder and ModelBuilder

sol- EntityTypeBuilder is meant for defining the structure.
     ModelBuilder is meant for binding the rull known as napper with structure.

     7th may

what is infrstructure layer or Repository ? (Environment setup)
A- Generic Repository.... Implementation... Generic interface...let me find the common operation across all the tables.


B- Sevice layer.... Business logic layer...interface...Do provide individiual operations.

infrstructure represent to Repository.Repository means, how we can perform set of database operation with database server.
so the we can prevent from dublicacy of code and Round trips.
to achive this we need generic interface .

infrstructure layer also known as Repository.

Remark: infrstructure layer will take the refrence of domain layer because we have define the context
or model in domain layer

        dotnet add refrence ..\Domain\Domain.csproj

public interface IGenericRepository<T> where T : BaseEntity
   {
      IEnumerable<T> GetAll();
      T Get(long id);
      void Insert(T entity);
      void Update(T entity);
      void Delete(T entity);
      void Remove(T entity);
      void SaveChanges();
    }

MAJOR C# POINT
if any interface is said to be generic , the implimentable class must be Generic.
Example
public interface GenericRepository<T> where T : BaseEntity
{
    
}

12th may
we are defining the GenericRepository.we are taking the refrence of domain layer to define the context.
Because context represent the database and dbset represent to tables

overall we need to associate dbset with Dbcontext. then dbset can point to table
        this.userManagementcontext=userManagementcontext;
        this.entities=this.userManagementcontext.Set<T>(); (like datatble and dataset)

        can you explian the service layer in onion arcchitecture

        service layer represent to business logic layer. business logic layer means.
         we are definig the operations for the particular table like user or userprofile.
         whereas in infratstucture laye we think for common operations for the table.
         frontend will be coremvc and angular

-------------13th may-----------
we are working at service layer also known as business logic layer.
we need to take a reference as well as infrstructure layer in service layer.

-----------------18th may--------------------

finaly we did all the layer in onion so front-end will be coreMvc.
we are acessing by the postman.

when we are definig the onion arcchitecture in dotnet core. 
1. EntityFrameworkCore is defining between  the domain layer
2. add Dbcontext is define in Api.
3. Migration arcchitecture says EntityFrameworkCore + addDbcontext() should define in single layer.
   because dotnetcore ef tool is enable to crate migration folder
