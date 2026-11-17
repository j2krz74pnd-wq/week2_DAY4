using Domain;
using Application;


// Student s1 = new Student()
// {
//   FirstName = "Abdullo",
//   LastName = "Ziyoyev",
//   Age = 20,
//   Grades = [1,2,3,4,5]  
// };

// Student s2 = new Student()
// {
//   FirstName = "Abdullo",
//   LastName = "Ziyoyev",
//   Age = 20,
//   Grades = [1,2,3,4,5]  
// };

// Student s3 = new Student()
// {
//   FirstName = "Abdullo",
//   LastName = "Ziyoyev",
//   Age = 20,
//   Grades = [1,2,3,4,5]  
// };

// Student s4 = new Student()
// {
//   FirstName = "Abdullo",
//   LastName = "Ziyoyev",
//   Age = 20,
//   Grades = [1,2,3,4,5]  
// };


// StudentService studentService = new StudentService();

// studentService.Create(s1);
// studentService.Create(s2);
// studentService.Create(s4);
// studentService.Create(s3);

// studentService.GetInfo();








Group g1 = new Group()
{
  Id=1,
  Name = "C# November",
  Description = "Bisyoriho namegzaran"
};

Group g2 = new Group()
{
  Id = 2 , 
  Name = " August",
  Description = "Hama gzashtagi"
};

GroupService groupService = new GroupService();

groupService.AddGroup(g1);
groupService.AddGroup(g2);

groupService.UpdateGroup(2,".Net August 18-20","One of the best group");

groupService.GetGroups();

groupService.DeleteGroup(2);

System.Console.WriteLine();

groupService.GetGroups();




