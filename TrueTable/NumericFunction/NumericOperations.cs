namespace AdvancedCalculator.TrueTable.NumericFunction {
    class NumericOperations {
        public static int not(int condition1) {
		if(condition1==0) return 1;
		return 0;
        }
        public static int or(int condition1, int condition2) {
            if(condition1==1 | condition2==1) return 1;
            return 0;
        }
        public static int nor(int condition1, int condition2) {
            if(condition1==1 | condition2==1) return 0;
            return 1;
        }
        public static int xor(int condition1, int condition2) {
            if(condition1==1 & condition2==1){
                return 0;
            }
            else if(condition1==0 & condition2==0){
                return 0;
            }
            return 1;
        }
        public static int xnor(int condition1, int condition2) {
            if(condition1==1 & condition2==1){
                return 1;
            }
            else if(condition1==0 & condition2==0){
                return 1;
            }
            return 0;
        }
        public static int and(int condition1, int condition2) {
            if(condition1==1 & condition2==1) return 1;
            return 0;
        }
        public static int nand(int condition1, int condition2) {
            if(condition1==1 & condition2==1) return 0;
            return 1;
        }
    }
}