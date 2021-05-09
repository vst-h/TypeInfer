using System;
using Xunit;
using static Vst.TypeInfer.InferType;

namespace Vst.TypeInfer.Test {
    static class TestTI {
        static void TestAction<T>(TI<T> _, Func<T, object> f) { }

        static void MethodRef() {
            TestAction(IT<string>, s => s.ToUpper());
        }

        static void CallResult() {
            TestAction(IT<string>(), s => s.ToUpper());
        }

        static void Delegate() {
            TI<string> t = IT<string>;
            TestAction(t, s => s.ToUpper());
        }

        static void TestCovariance(TI<object> _) {
            TestCovariance(IT<string>);
        }
    }

    public class InferType {

        [Fact]
        public void IsType() {
            TI<object> a1 = IT<object>;
            Assert.IsType<TI<object>>(a1);

            a1 = IT<string>;
            Assert.IsNotType<TI<string>>(a1);
            Assert.IsType<TI<object>>(a1);

            a1 = IT<string>();
            Assert.IsType<TI<string>>(a1);
        }
    }


}