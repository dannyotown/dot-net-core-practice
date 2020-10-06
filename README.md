# dot-net-core-practice

practicing dot net core

# notes

## Inheritance

### Access Modifiers

public: accessible outside of class
private: only accessible inside of class
protected: only accessible inside of class and derived classes (subclasses)
internal: accessible only from the same assembly (mostly used for classes)
protected internal: accessible from the same assembly and any derived classes

### Upcasting & Downcasting

    Upcast --> Circle circle = new Circle() ==> Shape shape = circle
    Downcast --> Circle anotherCircle = (Circle)shape
