import * as React from 'react';
import Button from '../button/button';
import './registerButton.css';

function RegisterButton() {
  return (
    <Button
      type = "submit"
      className="register-button"
      text="Enter"
    />
  );
}

export default RegisterButton;
