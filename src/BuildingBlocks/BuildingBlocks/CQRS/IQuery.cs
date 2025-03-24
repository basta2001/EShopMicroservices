using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    //IQuery<TResponse> predstavlja upit (query) u CQRS obrazcu.
    //Upiti su operacije čitanja koje ne menjaju stanje sistema,
    //već samo dohvatiti podatke.

    //Nasleđuje IRequest<TResponse>, što znači da je ovo zahtev koji
    //MediatR treba da procesuira i koji vraća neki rezultat tipa TResponse.
    //TResponse : notnull znači da tip odgovora (koji je TResponse) ne može biti null.
    //Ovo osigurava da upit uvek vrati validne podatke, a ne null vrednos
    public interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {
    }
}
