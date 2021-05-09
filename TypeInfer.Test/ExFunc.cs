using System;
using static Vst.TypeInfer.InferType;

namespace Vst.TypeInfer.Test {
    //interface Animal { }
    //interface Dog : Animal { }
    //struct Cat : Animal { }
    //static class ExFunc {
    //    static string Say<T>(this TI<T> _) where T : Animal {
    //        return "Animal";
    //    }
    //    static string Say(this TI<Animal> _) {
    //        return "Animal";
    //    }
    //    static string Say(this TI<Dog> _) => "Dog";
    //    static string Say(this TI<Cat> _) => "Cat";
    //    static void Test<T>(TI<Dog> dog, TI<Cat> cat, TI<T> animal) where T : Animal {
    //        dog.Say();
    //        cat.Say();
    //        animal.Say();
    //    }
    //    static void TestInfer<T>(TI<T> animal) where T : Animal {
    //        //TestInfer(InferType.IT</* 这里不会有类型提示 */>);
    //    }
    //}
}
