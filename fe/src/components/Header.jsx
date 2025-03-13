import '../index.css'
import {Link } from 'react-router-dom'
function Header(){
    return (
        <>
            <div class="flex justify-center space-x-4"  >
            <Link to="/" class="font-b rounded-lg px-3 py-2 text-gray-700 hover:bg-gray-100 hover:text-gray-900">
                Home
            </Link>
            <Link to="/products" class="font-b rounded-lg px-3 py-2 text-gray-700 hover:bg-gray-100 hover:text-gray-900">
                Products
            </Link>
            <a href="/projects" class="font-b rounded-lg px-3 py-2 text-gray-700 hover:bg-gray-100 hover:text-gray-900">
                Projects
            </a>
            <Link to="/login" class="font-b rounded-lg px-3 py-2 text-gray-700 hover:bg-gray-100 hover:text-gray-900">
                Đăng nhập
            </Link>

            </div>
        </>
    )
}
export default Header