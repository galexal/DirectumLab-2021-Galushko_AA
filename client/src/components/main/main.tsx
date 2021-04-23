import * as React from 'react';

interface IProps {
  className: string;
}

const Main: React.FC<IProps> = ({
  className,
  children
}) => {
  return (
    <div className={className}>
      {
        children
      }
    </div>
  );
};

export default Main;
