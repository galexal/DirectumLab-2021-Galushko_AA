import React from 'react';
import Greeting from '../greeting/greeting';
import RegisterButton from '../button/registerButton';

interface IProps {
  text: string;
  classNameForm: string;
  classNameHeader: string;
  roomId?: string;
}

const Form: React.FC<IProps> = ({
  text,
  classNameForm,
  classNameHeader,
  children,
  roomId
}) => {
  return (
    <div className={classNameForm}>
      <Greeting/>
      <h2 className={classNameHeader}>{text}</h2>
      {children}
      <RegisterButton roomId={roomId}/>
    </div>
  );
};

export default Form;
