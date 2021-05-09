# TypeInfer
Auxiliary type inference without writing types that are not necessary.

# Sample
``` C#
using System;
using System.Collections;
using Vst.TypeInfer;
using static Vst.TypeInfer.InferType;

class CollectionInit {
    class A : IEnumerable {
        public void Add<T>(Action<T, T, int, long> act) { }
        public void Add<T>(TI<T> ti, Action<T, T, int, long> act) { }
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }

    void Test() {
        var a1 = new A {
            { (string s1, string s2, int _, long _) => s1.ToUpper() },
            { IT<string>, (s1, s2, _, _) => s1.ToUpper() },
            { IT<DateTime>, (d1, d2, _, _) => d1.ToLongTimeString() },
        };
    }
}

static class ExtensionFn {
    class B<T1, T2, T3> { }

    static void Fn1<T1, T2, T3, T4>(this B<T1, T2, T3> b, Action<T4, T4, int, long> act) { }
    static void Fn1<T1, T2, T3, T4>(this B<T1, T2, T3> b, TI<T4> ti, Action<T4, T4, int, long> act) { }

    static void Test() {
        var b = new B<int, int, int>();

        b.Fn1((string s1, string s2, int _, long _) => s1.ToUpper());
        b.Fn1<int, int, int, string>((s1, s2, _, _) => s1.ToUpper());
        
        b.Fn1(IT<string>, (s1, s2, _, _) => s1.ToUpper());
    }
}

```