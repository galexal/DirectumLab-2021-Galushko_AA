import * as React from 'react';
import Button, {ButtonType} from '../button/button';
import './registerButton.css';

function RegisterButton() {
  return (
    <Button
      type = {ButtonType.SUBMIT}
      className="register-button"
      text="Enter"
    />
  );
}

export default RegisterButton;
