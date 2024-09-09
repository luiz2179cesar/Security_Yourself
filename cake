<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Super EPI - Equipamentos de Proteção Individual</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        header {
            background-color: #003366;
            color: white;
            text-align: center;
            padding: 1em;
        }
        nav {
            background-color: #004080;
            padding: 0.5em;
        }
        nav ul {
            list-style-type: none;
            padding: 0;
            margin: 0;
            display: flex;
            justify-content: center;
        }
        nav ul li {
            margin: 0 1em;
        }
        nav ul li a {
            color: white;
            text-decoration: none;
        }
        main {
            max-width: 1200px;
            margin: 2em auto;
            padding: 0 1em;
        }
        .product-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 2em;
        }
        .product-card {
            background-color: white;
            border-radius: 8px;
            padding: 1em;
            text-align: center;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }
        .product-card img {
            max-width: 100%;
            height: auto;
        }
        footer {
            background-color: #003366;
            color: white;
            text-align: center;
            padding: 1em;
            margin-top: 2em;
        }
    </style>
</head>
<body>
    <header>
        <h1>Super EPI</h1>
        <p>Sua segurança é nossa prioridade</p>
    </header>
    <nav>
        <ul>
            <li><a href="#">Início</a></li>
            <li><a href="#">Produtos</a></li>
            <li><a href="#">Sobre Nós</a></li>
            <li><a href="#">Contato</a></li>
        </ul>
    </nav>
    <main>
        <h2>Produtos em Destaque</h2>
        <div class="product-grid">
            <div class="product-card">
                <img src="/api/placeholder/200/200" alt="Capacete de Segurança">
                <h3>Capacete de Segurança</h3>
                <p>R$ 49,99</p>
                <button>Adicionar ao Carrinho</button>
            </div>
            <div class="product-card">
                <img src="/api/placeholder/200/200" alt="Luvas de Proteção">
                <h3>Luvas de Proteção</h3>
                <p>R$ 19,99</p>
                <button>Adicionar ao Carrinho</button>
            </div>
            <div class="product-card">
                <img src="/api/placeholder/200/200" alt="Óculos de Segurança">
                <h3>Óculos de Segurança</h3>
                <p>R$ 29,99</p>
                <button>Adicionar ao Carrinho</button>
            </div>
            <div class="product-card">
                <img src="/api/placeholder/200/200" alt="Protetor Auricular">
                <h3>Protetor Auricular</h3>
                <p>R$ 9,99</p>
                <button>Adicionar ao Carrinho</button>
            </div>
        </div>
    </main>
    <footer>
        <p>&copy; 2024 Super EPI. Todos os direitos reservados.</p>
    </footer>
</body>
</html>
