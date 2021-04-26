import * as React from 'react';
import Form from './form';
import Input from '../input/input';
import {withRouter} from 'react-router-dom';
import {RouteComponentProps} from 'react-router';
import './form.css';

interface IProps extends RouteComponentProps {
  roomId?: number;
}

const InviteForm: React.FC<IProps> = ({
  roomId
}) => {
  return (
    <Form
      roomId={roomId}
      text="Join the room"
      classNameForm="form"
      classNameHeader="form-header">
      <Input
      key="userInput"
      type="text"
      classNameLabel="form-input-label"
      classNameField="form-input-field"
      text="User name"
      placeholder="Enter your name"
      required={true}
    />
    </Form>
  );
}

export default withRouter(InviteForm);
