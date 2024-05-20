import React from 'react';
import Logo from '../../Assets/images/AppLogo.jpg';
import './Header.css'; 

const Header = () => {
    return (
            <div className="header">
                <img className="logo" src={Logo} alt="Logo" />
                <div className='exceptLogo'>

                    <div className='leftdiv'>
                        <a href="#" className="consumer">Consumer</a>
                        <a href="#" className="business">Business</a>     
                    </div>

                    <div className='rightdiv'>
                        <button>Register Your Business</button>
                        <button>Download the App</button>
                    </div>

                </div>
            </div>
    );
};
export default Header; 