import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Logotype from '../logotype/logotype';
import Main from '../main/main';
import RegisterForm from '../form/registerForm';
import './page.css';

function RegisterPage() {
  return (
    <div className="page">
      <Header/>
      <Main className="main" children={<RegisterForm/>} />
      <Footer/>
    </div>
  );
}

export default RegisterPage;
