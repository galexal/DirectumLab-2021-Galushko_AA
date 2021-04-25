import * as React from 'react';
import { Path } from '../../routes';
import Button, {ButtonType} from '../button/button';
import {history} from '../../index'
import './registerButton.css';

function RegisterButton() {
  const handleClick = () => {
    const roomId = 42;
    history.push(`${Path.planning}/${roomId}`)
  }
  return (
    <Button
      type = {ButtonType.SUBMIT}
      className="register-button"
      text="Enter"
      onClick={handleClick}
    />
  );
}

export default RegisterButton;
