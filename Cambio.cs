class Cambio {
    protected decimal conversaoDolar(decimal quantity) {
        return Math.Round(quantity*4.87m, 2);
    }

    protected decimal conversaoReal(decimal quantity) {
    return Math.Round(quantity*0.21m, 2);
    }

    /*
         valores de conversão não são exatos

    ex: digite US$1 e converterá para BRL$4,87
        volte e digite BRL$4,87 e passará a ser US$1,02
     */
}