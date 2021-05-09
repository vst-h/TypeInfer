namespace Vst.TypeInfer {

    /// <summary>
    /// </summary>
    public delegate TI<T> TI<out T>();

    /// <summary>
    /// </summary>
    public delegate TI<T1, T2> TI<out T1, out T2>();

    /// <summary>
    /// </summary>
    public delegate TI<T1, T2, T3> TI<out T1, out T2, out T3>();

    /// <summary>
    /// </summary>
    public delegate TI<T1, T2, T3, T4> TI<out T1, out T2, out T3, out T4>();

    /// <summary>
    /// </summary>
    public delegate TI<T1, T2, T3, T4, T5> TI<out T1, out T2, out T3, out T4, out T5>();

    /// <summary>
    /// </summary>
    public delegate TI<T1, T2, T3, T4, T5, T6> TI<out T1, out T2, out T3, out T4, out T5, out T6>();

    /// <summary>
    /// </summary>
    public delegate TI<T1, T2, T3, T4, T5, T6, T7> TI<out T1, out T2, out T3, out T4, out T5, out T6, out T7>();

    /// <summary>
    /// </summary>
    public delegate TI<T1, T2, T3, T4, T5, T6, T7, T8> TI<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8>();
    
    //public delegate TArg GetArg<out T, TArg>();

    //public delegate GetArg<T, TArg> TIA<out T, TArg>(TArg a);
    //public delegate TArg TIA<out T1, out T2, TArg>(TArg a);
    //public delegate TArg TIA<out T1, out T2, out T3, TArg>(TArg a);
    //public delegate TArg TIA<out T1, out T2, out T3, out T4, TArg>(TArg a);
    //public delegate TArg TIA<out T1, out T2, out T3, out T4, out T5, TArg>(TArg a);
    //public delegate TArg TIA<out T1, out T2, out T3, out T4, out T5, out T6, TArg>(TArg a);
    //public delegate TArg TIA<out T1, out T2, out T3, out T4, out T5, out T6, out T7, TArg>(TArg a);
    //public delegate TArg TIA<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, TArg>(TArg a);


}
