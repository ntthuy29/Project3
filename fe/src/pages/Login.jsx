import Header from "../components/Header";
function Login() {
  return (

    <div>
      <Header />
      <div class="flex   justify-center items-center h-screen">
      <div class="container w-100  flex justify-center items-center">
        <form class="flex flex-col gap-y-4 justify-center align-center w-96">
            <div class=" items-center flex h-16">
                <input class=" border " type="usename" placeholder="Nhập tên đăng nhập....."/>
            </div>
            <div class=" items-center flex h-16">
                <input class="border items-center" type="password" placeholder="Nhập mật khẩu....."/>
            </div>
            <button class="border ">Đăng nhập</button>
        </form>
        </div> n
      </div>
    </div>
  );
}
export default Login;