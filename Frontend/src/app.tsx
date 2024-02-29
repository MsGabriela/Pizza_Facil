import { useEffect, useState } from 'react';
import PedidoCard, { PedidoProps } from './components/PedidoCard';
import pedidosMock from './mocks/pedidos.json';
import Header from './components/Header';
import { dataValida } from './util/data';
import { removerAcentos } from './util/string';

export function App() {
  const [pedidos, setPedidos] = useState<PedidoProps[]>([]);
  const [dataBuscaIni, setDataBuscaIni] = useState<string>('');
  const [dataBuscaFim, setDataBuscaFim] = useState<string>('');
  const [pesquisaPedido, setPesquisaPedido] = useState<string>('');

  useEffect(() => {
    const data: PedidoProps[] = [];
    pedidosMock.pedidos.forEach((item) => {
      const dataArray: number[] = item.data
        .split('-')
        .map((item) => parseFloat(item));

      data.push({
        idPedido: item.idPedido,
        nomeCliente: item.nomeCliente,
        data: new Date(dataArray[0], dataArray[1], dataArray[2]),
        endereco: item.endereco,
        telefone: item.telefone,
        valorTotal: item.valorTotal,
        itens: item.itens,
      });
    });
    setPedidos(data);
  }, []);

  const filtraPedido = (): PedidoProps[] => {
    let pedidosFiltrados = pedidos;

    if (pesquisaPedido.length > 0) {
      pedidosFiltrados = pedidosFiltrados.filter(
        (pedido) =>
          removerAcentos(pedido.nomeCliente).includes(
            removerAcentos(pesquisaPedido),
          ) ||
          removerAcentos(pedido.endereco).includes(
            removerAcentos(pesquisaPedido),
          ) ||
          removerAcentos(pedido.telefone).includes(
            removerAcentos(pesquisaPedido),
          ),
      );
    }

    if (dataValida(dataBuscaIni) && dataValida(dataBuscaFim)) {
      pedidosFiltrados = pedidosFiltrados.filter(
        (pedido) =>
          pedido.data > new Date(dataBuscaIni) &&
          pedido.data < new Date(dataBuscaFim),
      );
    }

    return pedidosFiltrados;
  };

  const pedidosFiltrados: PedidoProps[] = filtraPedido();

  return (
    <>
      <Header />
      <div className="flex w-full h-[calc(100vh-3rem)]">
        <aside className="w-0 invisible md:visible md:w-36 bg-yellow-300 flex items-end justify-center pb-3 text-black shadow-md">
          Pizza Fácil
        </aside>
        <main className="p-3 flex-1 w-full flex flex-col gap-2">
          <section className="border border-gray-400 rounded-sm p-2 shadow-md flex flex-wrap">
            <div className="mr-20">
              <label
                className="block text-gray-700 text-sm font"
                htmlFor="pesquisa"
              >
                Pesquisa
              </label>
              <input
                className="border border-gray-300 px-3 py-2 rounded-md focus:outline-none focus:ring focus:border-blue-500"
                type="text"
                id="pesquisa"
                placeholder="Busca de Pedido"
                onChange={(e) => setPesquisaPedido(e.target.value)}
                value={pesquisaPedido}
              />
            </div>
            <div className="flex gap-2">
              <div>
                <label
                  className="block text-gray-700 text-sm"
                  htmlFor="dataPedido"
                >
                  Data Início
                </label>
                <input
                  className="border border-gray-300 px-3 py-2 rounded-md focus:outline-none focus:ring focus:border-blue-500"
                  type="date"
                  id="dataPedido"
                  placeholder="Data Início"
                  onChange={(e) => setDataBuscaIni(e.target.value)}
                  value={dataBuscaIni}
                />
              </div>
              <div>
                <label
                  className="block text-gray-700 text-sm"
                  htmlFor="dataPedido"
                >
                  Data Fim
                </label>
                <input
                  className="border border-gray-300 px-3 py-2 rounded-md focus:outline-none focus:ring focus:border-blue-500"
                  type="date"
                  id="dataPedido"
                  placeholder="Data Fim"
                  onChange={(e) => setDataBuscaFim(e.target.value)}
                  value={dataBuscaFim}
                />
              </div>
            </div>
          </section>
          <section className="border border-gray-400 rounded-sm p-2 flex flex-col gap-2">
            {pedidosFiltrados.length
              ? pedidosFiltrados
                  .sort(
                    (pedido1, pedido2) => pedido1.idPedido - pedido2.idPedido,
                  )
                  .map((item) => <PedidoCard key={item.idPedido} {...item} />)
              : 'Não existe pedido para o filtro especificado.'}
          </section>
        </main>
      </div>
    </>
  );
}
