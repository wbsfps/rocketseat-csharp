using HelloWorld.modificadores_de_acesso.cookie;
using HelloWorld.modificadores_de_acesso;

namespace HelloWorld;
class Program
{
    static void Main()
    {
        Car car = new("BMW");
        Cookie cookie = new Cookie();

        car.Ligar();
        car.Desligar();
        car.Teste2();
        // car.Teste1(); não é possível acessar

        cookie.Temperature();
    }
}
