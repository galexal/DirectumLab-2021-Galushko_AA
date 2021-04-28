import * as React from 'react';
import { Path } from '../../routes';
import Button, {ButtonType} from '../button/button';
import {withRouter} from 'react-router-dom';
import {RouteComponentProps} from 'react-router';
import './registerButton.css';

interface IProps extends RouteComponentProps {
roomId?: string;
}

const RegisterButton: React.FC<IProps> =  ({
  roomId,
  history
}) => {
  const handleClick = () => {
    const id = roomId || Math.round(Math.random()*(100-1)+1);
    history.push(`${Path.PLANNING}/${id}`)
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

export default withRouter(RegisterButton);
