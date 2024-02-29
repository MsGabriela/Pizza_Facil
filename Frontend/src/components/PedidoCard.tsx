interface ItensPedido {
  qtd: number;
  item: string;
  valor: number;
}

export interface PedidoProps {
  idPedido: number;
  nomeCliente: string;
  telefone: string;
  endereco: string;
  itens: ItensPedido[];
  data: Date;
  valorTotal: number;
}

export default function PedidoCard(props: PedidoProps) {
  return (
    <div className="border border-gray-400 rounded-sm bg-zinc-50 text-black w-full px-2 py-1">
      {/* <div className="rounded-br-lg rounded-tl-sm bg-yellow-400 w-24 text-center"> */}
      <div className="">Pedido #{props.idPedido}</div>
      {props.nomeCliente}
    </div>
  );
}
