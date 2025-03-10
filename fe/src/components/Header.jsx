import '../index.css'
function Header(){
    return (
        <>
            <div class="flex justify-center space-x-4"  >
            <a href="/dashboard" class="font-b rounded-lg px-3 py-2 text-gray-700 hover:bg-gray-100 hover:text-gray-900">
                Home
            </a>
            <a href="/team" class="font-b rounded-lg px-3 py-2 text-gray-700 hover:bg-gray-100 hover:text-gray-900">
                Team
            </a>
            <a href="/projects" class="font-b rounded-lg px-3 py-2 text-gray-700 hover:bg-gray-100 hover:text-gray-900">
                Projects
            </a>
            <a href="/reports" class="font-b rounded-lg px-3 py-2 text-gray-700 hover:bg-gray-100 hover:text-gray-900">
                Reports
            </a>

            </div>
        </>
    )
}
export default Header