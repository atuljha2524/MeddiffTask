# MeddiffTask
Problem1 : Created a dictionary which will map owner to list of files. Traverse the given map and added entries in the newly created map.
Problem2 : Used two pointer approach . one pointer at 0 and another pointer at size-1 . Both ponter will keep on comparing and moving towards each other and if there is a mismatch it return false otherwise true.
problem3 : Traverse the given log files line by line. If the line has error or warning in it then it will be saved to another text file.
problem4 : If the path passed to cd function starts with '/' then it is absolute path and it will be current path.
           If the path passed to cd function starts with a letter then it is relative path and it will be added to the current path.
           Else if path passed has '..' then last folder from the current path will be popped out and accordingly we can add it is not '..'
problem5 : http://localhost:16122/api/Student : With GET function will give you details of all the student.
           http://localhost:16122/api/Student/<rollNumber> : with GET function will return the details of given roll number.
           http://localhost:16122/api/Student : With POST function will add the student.
           http://localhost:16122/api/Student/<rollNumber> : With DELETE function will delete the student with given roll number.
           http://localhost:16122/api/Student : With PUT function will update the student which is passed as a json.  