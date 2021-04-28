import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Main from '../main/main';
import RegisterForm from '../form/registerForm';
import './page.css';
import Modal from '../modal/modal';

function RegisterPage() {
  return (
    <div className="page">
      <Header/>
      <Main className="main">
        <RegisterForm/>
      </Main>
      <Footer/>
    </div>
  );
}

export default RegisterPage;
