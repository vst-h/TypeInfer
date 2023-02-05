using System.Runtime.CompilerServices;

namespace Vst.TypeInfer {
    /// <summary>
    /// </summary>
    public static class InferType {

        public static TI<T> IT<T>() => IT<T>;

        public static TI<T1, T2> IT<T1, T2>() => IT<T1, T2>;

        public static TI<T1, T2, T3> IT<T1, T2, T3>() => IT<T1, T2, T3>;

        public static TI<T1, T2, T3, T4> IT<T1, T2, T3, T4>() => IT<T1, T2, T3, T4>;

        public static TI<T1, T2, T3, T4, T5> IT<T1, T2, T3, T4, T5>() => IT<T1, T2, T3, T4, T5>;

        public static TI<T1, T2, T3, T4, T5, T6> IT<T1, T2, T3, T4, T5, T6>() => IT<T1, T2, T3, T4, T5, T6>;

        public static TI<T1, T2, T3, T4, T5, T6, T7> IT<T1, T2, T3, T4, T5, T6, T7>() => IT<T1, T2, T3, T4, T5, T6, T7>;

        public static TI<T1, T2, T3, T4, T5, T6, T7, T8> IT<T1, T2, T3, T4, T5, T6, T7, T8>() => IT<T1, T2, T3, T4, T5, T6, T7, T8>;

//        public static TArg IT<T1, T2, TArg>(TArg a) => a;

//        public static TArg IT<T1, T2, T3, TArg>(TArg a) => a;

//        public static TArg IT<T1, T2, T3, T4, TArg>(TArg a) => a;

//        public static TArg IT<T1, T2, T3, T4, T5, TArg>(TArg a) => a;

//        public static TArg IT<T1, T2, T3, T4, T5, T6, TArg>(TArg a) => a;

//        public static TArg IT<T1, T2, T3, T4, T5, T6, T7, TArg>(TArg a) => a;

//        public static TArg IT<T1, T2, T3, T4, T5, T6, T7, T8, TArg>(TArg a) => a;

    }

}

