import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from './pages/Home.jsx'
import Login from './pages/Login.jsx';
import Products from './pages/Products.jsx';
import './index.css'
// import App from './App.jsx'
import Header from './components/Header.jsx'
createRoot(document.getElementById('root')).render(
  <StrictMode>
    <BrowserRouter>
    <Routes>
      <Route path="/" element={<Home/>} />
      <Route path="/login" element={
        <Login />
      } />
      <Route path="/products" element={<Products/>} />
      </Routes>
    </BrowserRouter>
  </StrictMode>
)
