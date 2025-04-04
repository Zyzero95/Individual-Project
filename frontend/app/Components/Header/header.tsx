import Link from "next/link";
import styles from "./header.module.css"


export default function Header() {
  return (
    <header className={styles.headerSection}>
        <h1 className={styles.headerTitle}>Animal Facts</h1>
        <nav className={styles.headerNav}>
            <ul>
                <li><Link href="/"/>Home</li>
                <li><Link href="/about"/>About</li>
                <li><Link href=""/>Random Animal</li>
            </ul>
        </nav>
    </header>
  )
}
