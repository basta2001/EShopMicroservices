using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    //Unit je specijalni tip u C# koji je ekvivalent void
    public interface ICommand : ICommand<Unit>
    { 
        
    }

    //ICommand je marker interfejs koji nasleđuje ICommand<Unit>.
    //Ovo je praktično prazan interfejs bez metoda, a koristi se kao marker da
    //označi da neka klasa predstavlja komandu koja se koristi u CQRS obrazcu za
    //izvršavanje radnje ili promenu stanja sistema
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
