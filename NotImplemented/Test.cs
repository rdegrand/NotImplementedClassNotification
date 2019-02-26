using System;

namespace NotImplementedClassNotification {
    public class Test : ITest {
        public string GetString() {
            throw new NotImplementedException();
        }
    }
}