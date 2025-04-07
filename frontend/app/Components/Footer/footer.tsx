import Link from "next/link";
import styles from "./footer.module.css"
import { ExternalLink } from "lucide-react";

export default function Footer() {
  return (
    <footer className={styles.footerSection}>
        <h2 className={styles.footerTitle}>Animal Facts</h2>
      <nav className={styles.footerNav}>
        <ul>
            <li><Link href="https://github.com/Zyzero95/Individual-Project">Link to Github<ExternalLink size={20}/></Link></li>
            <li><Link href="https://www.linkedin.com/in/viktor-l%C3%B6fgren-a17854162/">LinkedIn Profile<ExternalLink size={20}/></Link></li>
        </ul>
      </nav>
      <Link className={styles.footerToTop} href={"/"}>Back to top</Link>
    </footer>
  )
}
