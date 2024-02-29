export default function Header() {
  return (
    <header className="flex flex-row bg-yellow-300 text-black h-15 w-full h-12 shadow-md">
      <div className="font-semibold text-center my-auto h-full border-b border-r border-gray-600 w-36">
        Pizzaria <br /> Famiglia Aliboni
      </div>
      <nav className="flex gap-5 justify-center items-center mx-5 ">
        <div>Pedidos</div>
        <div>Financeiro</div>
        <div>Cadastro</div>
      </nav>
    </header>
  );
}
