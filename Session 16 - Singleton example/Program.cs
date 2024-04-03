using Session_16___Singleton_example;
using System;

Thread t1 = new Thread(() => 
{ 
   var instance = UploadService.getInstance(1);
});

Thread t2 = new Thread(() =>
{
    var instance = UploadService.getInstance(2);
});


t1.Start();
t2.Start();

t1.Join();
t2.Join();