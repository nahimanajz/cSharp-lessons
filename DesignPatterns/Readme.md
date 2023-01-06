## Factory design pattern

- you declare interface and classes that implement the interface
- Then you create FACTORY class that get parameter to clarify which object that should be returned
- Eventually you create instance of factory class that use to create instance of client class 

```
 OSFactory osf = new OSFactory();
Os os = osf.GetInstance("ios");
os.spec();

```