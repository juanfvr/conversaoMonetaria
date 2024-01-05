class Mensagens : Cambio { // class mensagens herda props. de class cambio
    private decimal quantity;
    public int inputChoice() {
        Console.WriteLine("1.Dolar\n2.Real\nEscolha: ");
        return int.Parse(Console.ReadLine());
            //  escolha da moeda
    }

    private decimal quantidade() {
        Console.WriteLine("Digite o valor em dolar: ");
        return decimal.Parse(Console.ReadLine());
    }

    public void condition(int opc) {
        switch(opc) { // validação de escolha e direcionamento
            case 1: 
                quantity = quantidade();
                Console.WriteLine($"{quantity}$ = {conversaoDolar(quantity):c} (05/01/2024)");
                break;
            case 2: 
                quantity = quantidade();
                Console.WriteLine($"{quantity:c} = {conversaoReal(quantity)}$ (05/01/2024)");
                break;
            default:
                Console.WriteLine("Opção Inválida.");
                break;
        }
    }
}