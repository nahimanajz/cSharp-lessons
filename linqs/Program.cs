
IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
    };

var filteredResult = from s in studentList
                    where s.Age > 12 && s.Age < 20
                    
                    select s;
foreach ( var  st in filteredResult) Console.WriteLine(st.Age);           

// Filter by using delegate
Func<Student, bool> isUnderAge= delegate(Student st) {
    return st.Age < 18;
};

var filter  = from s in studentList
                        where isUnderAge(s) 
                        select s;
foreach ( var  stu in filter) Console.WriteLine($" Under age student: {stu.StudentName}");           
