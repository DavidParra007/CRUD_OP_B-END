// See https://aka.ms/new-console-template for more information
using Data;
using Data.Interface;
using Entities;
using Entities._Entities;
using Microsoft.EntityFrameworkCore;

Context context = new Context();

ICRUD<Prospecto> crud = new CRUD<Prospecto>(context);


Prospecto p = crud.Get(202);
crud.Delete(202);
string s = "";



return;
/*
Post p = crud.Get(2);

p.title = "---------Titulo Actualizdo_______________________________________________";
Console.WriteLine(p.title);
p.userid = 2;
p.body = "----------Cuerpo del post Actualizado";

crud.Update(p);*/
Post px = new Post();

px.body = "CUERPO";
//crud.Add(px);


//crud.Add(p);


/*
Post p = new Post();

p.title = "Titulo insertado";
p.userid = 2;
p.body = "Cuerpo del post insertado";

crud.Add(p);
*/





//IEnumerable<Post> pa = crud.All();

Console.WriteLine("Hello, World!");