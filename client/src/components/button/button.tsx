import React from 'react';

export enum ButtonType {
  BUTTON='button',
  SUBMIT='submit',
  RESET='reset'
}

interface IProps {
  text: string;
  onClick?: () => void;
  type: ButtonType | undefined;
  className: string;
}

const Button: React.FC<IProps> = ({
  text,
  onClick,
  type,
  className
}) => {
  return (
    <button
      onClick={onClick}
      className={className}
      type = {type}
    >
      {text}
    </button>
  );
};

export default Button;
